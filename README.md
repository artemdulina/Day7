## Day7


----------


**Задание 1**.

Разработать класс Book
```c#
public class Book : IEquatable<Book>, IComparable<Book>
{
public string Author { get; set; }
public string Title { get; set; } 
 + два-три нужных и стандартных для книги свойства желательно не строкового типа
//TODO 
}
```
переопределив для него необходимые методы класса Object (посмотреть рекомендации по переопределению GetHashCode http://blogs.msdn.com/b/ruericlippert/archive/2011/03/20/guidelines-and-rules-for-gethashcode.aspx) и методы интерфейсов. Реализовать алгоритм сортировки для массива объектов Book таким образом, чтобы можно было выполнить сортировку элементов массива по автору, заголовку книги и т.д.


----------


Задание 2. 

Разработать иерархию классов для описания геометрических фигур - Окружности, Треугольника, Квадрата, Прямоугольника…. Классы должны описывать свойства фигуры и иметь методы для вычисления площади и периметра фигуры.
