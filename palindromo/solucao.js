const polindromo = (word) => {
    const wordInverse = word.split("").reverse();
    for (let i = 0; i < word.length; i++) {
        if (word[i] != wordInverse[i]){
            return false;
        }
    };
    return true;
};

console.log(polindromo('bolacha'));
console.log(polindromo('abelha'));
console.log(polindromo('asa'));