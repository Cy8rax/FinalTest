# Итоговая проверочная работа.

**Задача:** *Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*

1. Начало;
2. Создание 2х массивов - "array" - исходный и "resultArr" - куда будут в дальнейшем записаны данные соответствующие условию;
3. Создаю переменную index и присваиваю ей значение "0" для счетчика в цикле;
3. Запускаю цикл с условием "index < array.Length" - длины массива:
    * в случае если условие выполняется, запускается второе условие:
        1) если элемент массива "array[]" с порядковым номером "index" меньше или равен 3, то следующим шагом "resultArr[]" массив будет увеличен на 1 слот и туда будет записан элемент из "array[]";
        2) иначе этот шаг игнорируется;
        3) index увеличивается на +1 для перехода к следующему элементу массива или выхода из цикла;
    * если условие "index < array.Length" - не выполняется, то массив "resultArr[]" выводится на экран;
4. Конец.