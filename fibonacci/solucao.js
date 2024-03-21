const fibonacci = (number) => {
    const sequence = [0, 1];
    for (let i = 2; i < number; i++) {
        sequence[i] = sequence[i - 1] + sequence[i - 2];
    };
    return sequence;
};

console.log(fibonacci(10));