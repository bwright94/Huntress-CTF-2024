import socket
import re

# Server details
HOST = 'challenge.ctf.games'
PORT = 30073

# Response rules
responses = {
    'block': 'advance',
    'advance': 'retreat',
    'retreat': 'strike',
    'strike': 'block'
}

# Regular expression to match "Opponent move: <move>"
move_pattern = re.compile(r'Opponent move: (\w+)')

def interact_with_server():
    buffer = ""  # Store partial data

    # Create a socket connection
    with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as s:
        s.connect((HOST, PORT))
        print(f"Connected to {HOST}:{PORT}")
        
        # Keep interacting with the server
        while True:
            # Receive data in smaller chunks
            chunk = s.recv(256).decode('utf-8', errors='ignore')
            if not chunk:
                print("Connection closed by the server.")
                break
            
            # Add the chunk to the buffer
            buffer += chunk
            print(f"Server: {chunk}")

            # Search for opponent move in the buffer
            match = move_pattern.search(buffer)
            if match:
                opponent_move = match.group(1)
                if opponent_move in responses:
                    # Send the appropriate response
                    response = responses[opponent_move]
                    print(f"Client: {response}")
                    s.sendall(response.encode('utf-8'))
                    
                    # Clear the buffer to avoid processing old data
                    buffer = ""

if __name__ == "__main__":
    interact_with_server()
