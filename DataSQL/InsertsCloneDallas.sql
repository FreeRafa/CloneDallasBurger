-- Categorias
INSERT INTO Categoria (Nome, Ordem) VALUES
('Burgers', 1), ('Sides', 2), ('Sweet', 3), ('Beers', 4), ('Kombuchas', 5), ('Drinks', 6);
GO
 
-- Funcionarios (exemplo)
INSERT INTO Funcionario (Nome, Cargo, Usuario, SenhaHash) VALUES
('Gabriel Silva', 'Gerente', 'ana.silva', 'HASH_AQUI'),
('Rafael Velloso', 'Garcom', 'bruno.costa', 'HASH_AQUI'),
('Carla Mendes', 'Garcom', 'carla.mendes', 'HASH_AQUI');

GO
 
-- Mesas (exemplo, 10 mesas)
INSERT INTO Mesa (Numero, Capacidade)
SELECT TOP 10 ROW_NUMBER() OVER (ORDER BY (SELECT NULL)), 4
FROM sys.objects;
GO
 
-- Ingredientes / Molhos
-- DisponivelComoExtra = 1 apenas para os itens que fazem sentido vender como adicional pago
INSERT INTO Ingrediente (Nome, Tipo, PrecoAdicional, Vegano, DisponivelComoExtra) VALUES
('Dallas Sauce', 'Molho', 0, 1, 0),
('Mayo', 'Molho', 0, 1, 0),
('Basil Mayo', 'Molho', 0, 0, 0),
('Truffle Mayo', 'Molho', 0, 0, 0),
('Chipotle Sauce', 'Molho', 0, 0, 0),
('Samourai Sauce', 'Molho', 0, 0, 0),
('Cheddar', 'Queijo', 1.0, 0, 1),
('Grana Padano', 'Queijo', 1.0, 0, 1),
('Swiss Cheese', 'Queijo', 1.0, 0, 1),
('American Cheese', 'Queijo', 1.0, 0, 1),
('Cheddar Vegano', 'Queijo', 1.0, 1, 1),
('Bacon Crocante', 'Extra', 1.5, 0, 1),
('Jalapenos', 'Vegetal', 0.5, 1, 1),
('Cebola Crua', 'Vegetal', 0, 1, 0),
('Cebola Caramelizada', 'Vegetal', 0.5, 1, 1),
('Cebola Crocante (Fried Onions)', 'Vegetal', 0.5, 1, 1),
('Pickles', 'Vegetal', 0, 1, 0),
('Alface', 'Vegetal', 0, 1, 0),
('Rucula', 'Vegetal', 0, 1, 0),
('Agriao (Watercress)', 'Vegetal', 0, 1, 0),
('Tomate Grelhado', 'Vegetal', 0.5, 1, 1),
('Curgete Grelhada', 'Vegetal', 0.5, 1, 1),
('Cogumelos Salteados', 'Vegetal', 1.0, 1, 1),
('Patty de Carne 165g', 'Proteina', 2.5, 0, 1),
('Patty Vegano', 'Proteina', 2.5, 1, 1);
GO
 
-- Produtos: BURGERS
INSERT INTO Produto (CategoriaId, Nome, Descricao, Preco, Vegano, PermiteTrocaProteina)
SELECT CategoriaId, 'Dallas Classic Cheeseburger',
       '165g beef patty, cheddar, lettuce, chopped onions, pickles, Dallas sauce', 11.5, 0, 1
FROM Categoria WHERE Nome = 'Burgers';
 
INSERT INTO Produto (CategoriaId, Nome, Descricao, Preco, Vegano, PermiteTrocaProteina)
SELECT CategoriaId, 'Italian Summer Burger',
       '165g beef patty, Grana Padano, arugula, grilled marinated tomato and courgette, basil mayo', 12.5, 0, 1
FROM Categoria WHERE Nome = 'Burgers';
 
INSERT INTO Produto (CategoriaId, Nome, Descricao, Preco, Vegano, PermiteTrocaProteina)
SELECT CategoriaId, 'Chipotle Burger',
       '165g beef patty, cheddar, caramelised onions, jalapenos, chipotle sauce', 12.5, 0, 1
FROM Categoria WHERE Nome = 'Burgers';
 
INSERT INTO Produto (CategoriaId, Nome, Descricao, Preco, Vegano, PermiteTrocaProteina)
SELECT CategoriaId, 'Truffle Mushroom Burger',
       '165g beef patty, swiss cheese, arugula, sauteed mushrooms, truffle mayo', 12.9, 0, 1
FROM Categoria WHERE Nome = 'Burgers';
 
INSERT INTO Produto (CategoriaId, Nome, Descricao, Preco, Vegano, PermiteTrocaProteina)
SELECT CategoriaId, 'Bicky Burger',
       '165g beef patty, American cheese, watercress, fried onions, samourai sauce', 12.5, 0, 1
FROM Categoria WHERE Nome = 'Burgers';
 
INSERT INTO Produto (CategoriaId, Nome, Descricao, Preco, Vegano, PermiteTrocaProteina)
SELECT CategoriaId, 'Vegan Dallas Classic Burger',
       'Vegan patty, vegan cheddar, lettuce, chopped onions, pickles, vegan Dallas sauce', 12.9, 1, 0
FROM Categoria WHERE Nome = 'Burgers';
GO
 
-- Produtos: SIDES
INSERT INTO Produto (CategoriaId, Nome, Descricao, Preco, Vegano)
SELECT CategoriaId, 'Coleslaw', NULL, 3.5, 1 FROM Categoria WHERE Nome = 'Sides';
 
INSERT INTO Produto (CategoriaId, Nome, Descricao, Preco, Vegano)
SELECT CategoriaId, 'Crispy French Fries', NULL, 3.5, 1 FROM Categoria WHERE Nome = 'Sides';
 
INSERT INTO Produto (CategoriaId, Nome, Descricao, Preco, Vegano)
SELECT CategoriaId, 'Cheesy Loaded Fries',
       'Raclette & cheddar sauce, crispy bacon, jalapenos and chives', 5.5, 0
FROM Categoria WHERE Nome = 'Sides';
GO
 
-- Produtos: SWEET
INSERT INTO Produto (CategoriaId, Nome, Descricao, Preco, Vegano)
SELECT CategoriaId, 'Ice Cream Cookie Sandwich',
       'Creamy vanilla ice cream in a crunchy double dark chocolate chip cookie sandwich with peanut crust', 5.5, 0
FROM Categoria WHERE Nome = 'Sweet';
GO
 
-- Produtos: BEERS (Dois Corvos Craft Beers)
INSERT INTO Produto (CategoriaId, Nome, Descricao, Preco)
SELECT CategoriaId, 'Pilsner', 'Dois Corvos', 3.5 FROM Categoria WHERE Nome = 'Beers';
 
INSERT INTO Produto (CategoriaId, Nome, Descricao, Preco)
SELECT CategoriaId, 'IPA', 'Dois Corvos', 3.7 FROM Categoria WHERE Nome = 'Beers';
 
INSERT INTO Produto (CategoriaId, Nome, Descricao, Preco)
SELECT CategoriaId, 'Dallas Session IPA', 'Dois Corvos', 4.0 FROM Categoria WHERE Nome = 'Beers';
GO
 
-- Produtos: KOMBUCHAS
INSERT INTO Produto (CategoriaId, Nome, Descricao, Preco)
SELECT CategoriaId, 'Ummi Lemon Ginger', 'Alc. 6%', 5.0 FROM Categoria WHERE Nome = 'Kombuchas';
 
INSERT INTO Produto (CategoriaId, Nome, Descricao, Preco)
SELECT CategoriaId, 'Ummi Mango Turmeric', 'Alc. 6%', 5.0 FROM Categoria WHERE Nome = 'Kombuchas';
 
INSERT INTO Produto (CategoriaId, Nome, Descricao, Preco)
SELECT CategoriaId, 'Bouche Lemondrop', NULL, 4.5 FROM Categoria WHERE Nome = 'Kombuchas';
 
INSERT INTO Produto (CategoriaId, Nome, Descricao, Preco)
SELECT CategoriaId, 'Bouche Earlybird', NULL, 4.5 FROM Categoria WHERE Nome = 'Kombuchas';
GO
 
-- Produtos: DRINKS
INSERT INTO Produto (CategoriaId, Nome, Descricao, Preco)
SELECT CategoriaId, 'Coke / Coke Zero', NULL, 3.5 FROM Categoria WHERE Nome = 'Drinks';
 
INSERT INTO Produto (CategoriaId, Nome, Descricao, Preco)
SELECT CategoriaId, 'Homemade Iced Tea', NULL, 3.5 FROM Categoria WHERE Nome = 'Drinks';
 
INSERT INTO Produto (CategoriaId, Nome, Descricao, Preco)
SELECT CategoriaId, 'Purified Water (70cl)', NULL, 2.5 FROM Categoria WHERE Nome = 'Drinks';
GO
 