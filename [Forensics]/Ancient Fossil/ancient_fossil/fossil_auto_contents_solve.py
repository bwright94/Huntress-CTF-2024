import os
import subprocess

# Path to the file containing the list of commit hashes
commit_file = 'fossil_commits.txt'

# Path to the output file
output_file = 'fossil_auto_contents_out.log'

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
        
        # Decode the contents of the file(s)
        # Here we assume the output contains the file name directly
        file_name = output.strip()  # Ensure any extra whitespace is removed
        
        if os.path.exists(file_name):
            print(f"Decoding contents of file: {file_name}")
            
            # Run 'cat [filename] | base64 -d' to decode the file contents
            with open(file_name, 'rb') as f:
                file_contents = f.read()  # Read the contents of the file
            
            # Run base64 decoding
            decoded = subprocess.run(['base64', '-d'], input=file_contents, stdout=subprocess.PIPE, stderr=subprocess.PIPE)
            
            # Capture the decoded output
            decoded_contents = decoded.stdout.decode().strip()
            if decoded_contents:
                print(f"Decoded contents for {file_name} from commit {commit}: {decoded_contents}")
                
                # Save decoded contents to the output file
                with open(output_file, 'a') as f:
                    f.write(f"{commit}: {decoded_contents}\n")
            else:
                print(f"No decoded content for {file_name} from commit: {commit}")
        else:
            print(f"File {file_name} does not exist for commit: {commit}")
    else:
        print(f"No output for commit: {commit}")
