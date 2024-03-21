def polindromo(word):
    word_inverse = word[::-1]
    for i in range(len(word)):
        if word[i] != word_inverse[i]:
            return False
    return True

print(polindromo('bolacha'));
print(polindromo('abelha'));
print(polindromo('asa'));