def fibonacci(number):
    sequence = [0, 1]
    for i in range(2, number):
        sequence.append(sequence[i - 1] + sequence[i - 2])
    return sequence

print(fibonacci(10))
