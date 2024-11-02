#!/bin/bash

# Check if keys_cut.txt exists
if [ ! -f keys_cut.txt ]; then
    echo "File keys_cut.txt not found!"
    exit 1
fi

# Base URL
base_url="http://challenge.ctf.games:31062/bucket/"

# Loop through each line in keys_cut.txt
while IFS= read -r key; do
    # Construct the full URL
    full_url="${base_url}${key}"
    # Run wget command
    echo "Downloading from: $full_url"
    wget "$full_url"
done < keys_cut.txt
