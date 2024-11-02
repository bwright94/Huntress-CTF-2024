import os
import subprocess

# Path to the file containing the list of commit hashes
commit_file = 'fossil_commits.txt'

# Path to the output file
output_file = 'fossil_auto_out.log'

# Ensure the output file is cleared or created fresh
with open(output_file, 'w') as f:
    f.write('')

# Read all commit hashes from the file
with open(commit_file, 'r') as f:
    commits = [line.strip() for line in f.readlines()]

# Iterate over each commit
for commit in commits:
    print(f"\nChecking out commit: {commit}")
    
    # Run 'fossil co <commit>'
    fossil_command = ['fossil', 'co', commit]
    result = subprocess.run(fossil_command, stdout=subprocess.PIPE, stderr=subprocess.PIPE)
    
    # Capture the output (if any)
    output = result.stdout.decode().strip()
    
    if output:
        print(f"Output from fossil co {commit}: {output}")
        
        # Check if the output is base64 encoded (in this case, it only contains base64 characters)
        if all(c in 'ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/=\n' for c in output):
            print(f"Decoding base64 output for commit: {commit}")
            
            # Run 'base64 -d' to decode
            base64_command = ['base64', '-d']
            decoded = subprocess.run(base64_command, input=output.encode(), stdout=subprocess.PIPE, stderr=subprocess.PIPE)
            
            # Output the decoded content
            decoded_output = decoded.stdout.decode().strip()
            if decoded_output:
                print(f"Decoded content for {commit}: {decoded_output}")
                
                # Save decoded content to the output file
                with open(output_file, 'a') as f:
                    f.write(f"{commit}: {decoded_output}\n")
            else:
                print(f"Failed to decode base64 for commit: {commit}")
        else:
            print(f"Skipping base64 decoding for commit: {commit} (output doesn't look like base64)")
    else:
        print(f"No output for commit: {commit}")
