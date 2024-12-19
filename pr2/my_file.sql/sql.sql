-- Створення таблиці 'items' з початковими полями
CREATE TABLE items (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(50),
    price DECIMAL(8, 2)
);

-- Вставка тестових даних
INSERT INTO items (name, price) VALUES
('Item1', 10.50),
('Item2', 20.00),
('Item3', 15.75),
('Item4', 30.25);

-- Вибір записів з парним id (без використання процедури)
SELECT * FROM items WHERE id % 2 = 0;
