# Задача:
 Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
# Решение № 1: 
1. Задаём строчный массив.
2. Объявляем переменную count и присваиваем ей значение 0.
3. С помощью метода находим кол-во элементов заданного массива, где длина строк меньше или равна 3 символам.
4. В другом методе, создаём новый массив, длина которого равна найденному кол-ву элементов.
5. Находим элементы соответствующие условию(длина строк меньше или равна 3 символам) и записываем их в новый массив.
6. Выводим новый массив.

# Решение №2:
1. Задаём строчный массив.
2. В методе создаём новый пустой массив.
3. Находим строки соответствующие условию(длина строк меньше или равна 3 символам).
4. Если нашли строки, то вызываем второй метод, который возращает нам массив на 1 размер больше.
5. В конец нового массива добовляем значение которое нашли.