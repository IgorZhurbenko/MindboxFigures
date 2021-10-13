# MindboxFigures

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
