import os
import subprocess

# Path to the file containing the list of commit hashes
commit_file = 'fossil_commits.txt'

# Path to the output file
output_file = 'fossil_auto_names_out.log'

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
        
        # The output represents a file name (base64 encoded), so we decode the file name
        print(f"Decoding base64 file name for commit: {commit}")
        
        # Run 'base64 -d' to decode the file name
        base64_command = ['base64', '-d']
        decoded = subprocess.run(base64_command, input=output.encode(), stdout=subprocess.PIPE, stderr=subprocess.PIPE)
        
        # Output the decoded file name
        decoded_filename = decoded.stdout.decode().strip()
        if decoded_filename:
            print(f"Decoded file name for {commit}: {decoded_filename}")
            
            # Save decoded file name to the output file
            with open(output_file, 'a') as f:
                f.write(f"{commit}: {decoded_filename}\n")
        else:
            print(f"Failed to decode base64 file name for commit: {commit}")
    else:
        print(f"No output for commit: {commit}")
