dot_net_c_sharp_project
=======================

dot_net_c_sharp_project

Models
У всех моделей есть поле long id

1. Товар - Product - поля: name, madeby, price, id_attributes(List)
2. Аттрибуты - Attribute - поля: memory, dpi, cpuSpeed, cache, socket and etc.
3. Пользователь - User - поля: name, login, password, id_role
4. роль - Role - поля: access, id_rule
5. Полный комп - Computer - поля: id_products(List), description
6. Предыдущая цена - PreviewPrice - поля: id_product, time_start, time_end
7. Заказ - Order - поля: id_user, time, id_products(List), summery_price, id_discount, id_credit, id_delivery, id_computers(List)
8. Скидки - Discount - поля: percent, id_product
9. Категории - Category - поля: name, id_products(List), id_computer
10. Правила доступа - Rule - поля: description
11. Кредит - Credit - поля: price, percent, time_start, time_end
12. Доставка - Delivery - поля: address, price, time_max

