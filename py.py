#solicitar al usuario los dos numeros para la operacion
num1 = float(input("introduce el primer numero:"))
num2 = float(input("introduce el segundo numero:"))
#solicitar al usuario la operacion que desea realizar 
operacion = input("elige una operacion(+, -, *, /):")
# realizar la operacion seleccionada
if operacion == '+':
    resultado = num1 + num2
elif operacion == '-':
    resultado = num1 - num2 
elif operacion == '*':
    resultado = num1 * num2 
elif operacion == '/':
    if num2 == 0:
        resultado  = "error: divicion por cero"
    else :
        resultado =num1 / num2 
else: resultado = "operacion no valida"
print ("el resultado es:", resultado)
