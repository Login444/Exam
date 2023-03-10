# Условие задачи
Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

# Описание решения

1. Предлагаем пользователю самому ввести колличество строк, которые мы будем проверять.
2. Используя метод **GetArray** предлагаем пользователю ввести строки в массив заданной длинны. Длинну массива пользователь сам определил в предыдущем шаге.
3. С помощью метода **ShowArray** показываем пользователю его массив.
4. С помощью метода **ShowNewArray** выводим новый массив строк, длинна которых меньше либо равна 3.

# Описания методов
## GetArray
Метод предлагает пользователю поочередно ввести строки, которые далее будут проверяться. В качестве аргумента метода мы используем длинну массива, которую мы заранее попросили пользователя ввести.
Далее с помощью цикла *for* мы просим пользователя по порядку ввести строки до тех пор пока счетчик *i* не будет равен длине массива.
## ShowArray
Этот метод так же использует цикл *for* с счетчиком *i* для того что бы по порядку вывести в консоль массив введеных строк.
## ShowNewArray
Этот метод с помощью цикла *for* поочередно проверяет каждый элемент массива строк пользователя. В новый массив добавляются лиш те строки, которые меньше либо равны 3, для это используется оператор *if*. *if* проверяет каждый каждый элемент массива на выполнение условия "меньше либо равен 3". Те элементы которые удовлетворяют условию попадают в новый массив. Если элемент массива больше 3, то метод его пропускает и переходит к следующей итерации цикла.