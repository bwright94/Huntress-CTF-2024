## https://youtu.be/yt2v_cGYcn4

ciphertext = b'\xEA\x3F\x3D\x2A\x62\x68\x75\x63'
known_plaintext = b'\x89\x50\x4E\x47\x0D\x0A\x1A\x0A'

def xor_values(ciphertext, known_plaintext):
    decrypted = bytearray()
    for i in range(len(ciphertext)):
        decrypted_byte = known_plaintext[i] ^ ciphertext[i % len(known_plaintext)]
        decrypted.append(decrypted_byte)
    return decrypted

def main():
    key = xor_values(ciphertext, known_plaintext)
    print(key)

if __name__ == "__main__":
    main()