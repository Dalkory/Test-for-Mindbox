# Test-for-Mindbox
C# developer junior / middle (.net, full-stack / back-end)

## Task 1

#### Напишите на С# библиотеку для поставки внешним клиентам, которая умеет вычислять площаль круга по радиусу треугольника по трем сторонам

- dotnet new classlib -o AreaOfTheFigure. Создаем библиотеку

- dotnet new xunit -o AreaOfTheFigure.Tests. Содаем тесты

- dotnet add reference ../AreaOfTheFigure/AreaOfTheFigure.csproj. Подкулючаем библиотеку к тестам

- dotnet test AreaOfTheFigure.Tests. Запускам тесты из папки Task01

## Task 2

#### В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответсоствовать много категрий, в одной категроии может быть много продуктов. Напишите SQL запрос для выбора всех пар Имя продкута - Имя категории. Если у продукта нет категрий, то имя все равно должно выводиться.

- Предположим, что таблицы выглядят так -

```sql
CREATE TABLE Products
(
    ProductID INT PRIMARY KEY,
    ProductName NVARCHAR(255)
)

CREATE TABLE Categories
(
    CategoryID INT PRIMARY KEY,
    CategoryName NVARCHAR(255)
)

CREATE TABLE ProductCategories
(
    ProductID INT FOREIGN KEY REFERENCES Products(ProductID),
    CategoryID INT FOREIGN KEY REFERENCES Categories(CategoryID),
    PRIMARY KEY (ProductID, CategoryID)
)
```