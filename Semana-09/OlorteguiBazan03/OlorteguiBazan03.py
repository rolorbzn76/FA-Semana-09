import random
suma = 0
can1=0
can2=0
can3=0
can4=0
#Generar 15 aleatorios entre 1250 a 10000
for i in range(1,16):
    aleatorio = random.randint(1250,10000)
    print(aleatorio)
    suma += aleatorio;  # Sumamos los números aleatorios
    if 1250 <= aleatorio <= 3000:
        can1 += 1
    elif 3001 <= aleatorio <= 5000:
        can2 += 1
    elif 5001 <= aleatorio <= 6999:
        can3 += 1
    else:   # aleatorio >= 7000
        can4 += 1

print(f"Suma: {suma}")
print(f"Cantidad entre 1250 y 3000: {can1}")
print(f"Cantidad entre 3001 y 5000: {can2}")
print(f"Cantidad entre 5001 y 6999: {can3}")
print(f"Cantidad mayor a 7000: {can4}")

