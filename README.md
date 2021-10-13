# MindboxFigures

Ответ на первое задание:

Я решил, что следует заложить логику вычисления площади фигуры в ее объект и привязать к интерфейсу. Тогда площадь фигуры будет вычислена при создании и не будет меняться, так 
как фигуры в данном коде иммутабельны.

Последующее расширение кода в сторону добавления новых фигур возможно через создание новых классов, реализующих IMeasurableAreaFigure.

Ответ на второе задание:

У нас должно быть три таблицы для организации связи многие-ко-многим: Products, Categories и Product_Category, в которой хранится информация по всем соединениям между объектами.

select p.Name as Product, c.Name as Category from 
Products as p

left join
Product_Category as pc
on p.ID = pc.ProductID

left join 
Categories as c
on c.ID = pc.CategoryID
