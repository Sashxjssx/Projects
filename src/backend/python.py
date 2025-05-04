def add(n1, n2):
    return n1 + n2


def sub(n1, n2):
    return n1 - n2


def mul(n1, n2):
    return n1 * n2


def div(n1, n2):
    return n1 / n2


def prc(n1, n2):
    return (n1 / n2) * 100


print("Operações Disponíveis:\n"
      "1. Adição\n"
      "2. Subtração\n"
      "3. Multiplicação\n"
      "4. Divisão\n" \
      "5. Porcentagem\n")


sel = int(input("Selecione uma das Operações (1-5): "))

n1 = int(input("Digite o Primeiro Número: "))
n2 = int(input("Digite o Segundo Número: "))


if sel == 1:
    print(n1, "+", n2, "=", add(n1, n2))

elif sel == 2:
    print(n1, "-", n2, "=", sub(n1, n2))

elif sel == 3:
    print(n1, "*", n2, "=", mul(n1, n2))

elif sel == 4:
    print(n1, "/", n2, "=", div(n1, n2))

elif sel == 5:
    print(n1, "/", n2, "x 100", "=", prc(n1, n2))

else:
    print("Opção Inválida")