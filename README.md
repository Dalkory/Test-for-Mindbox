# Test-for-Mindbox
Стажер Python/C# developer

## Task 1

#### Напишите на С# библиотеку для поставки внешним клиентам, которая умеет вычислять площаль круга по радиусу треугольника по трем сторонам

- dotnet new classlib -o AreaOfTheFigure. Создаем библиотеку

- dotnet new xunit -o AreaOfTheFigure.Tests. Содаем тесты

- dotnet add reference ../AreaOfTheFigure/AreaOfTheFigure.csproj. Подкулючаем библиотеку к тестам

- dotnet test AreaOfTheFigure.Tests. Запускам тесты из папки Task01

## Task 2

#### В PySpark приложении датафреймами (pyspark.sql.DataFrame) заданы продукты, категории и их связи. Каждому продукту может соответствовать несколько категорий или ни одной. А каждой категории может соответствовать несколько продуктов или ни одного. Напишите метод на PySpark, который в одном датафрейме вернет все пары «Имя продукта – Имя категории» и имена всех продуктов, у которых нет категорий.

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
