dot_net_c_sharp_project
=======================
1-4 забираю себе (Настя)

1. Продукт (Товар)    - Product              -  id (long), name(string), price(double), description(string)
2. Атрибут            - Attribute            -  id, name, description
3. Компьютер          - Computer             -  id, price, description
4. Категории          - Category             -  id, name
5. Пользователь       - User                 -  id, login(string), password(string), firstname(string), secondname(string)
6. Роль               - Role                 -  id, name, description
7. Кредит             - Credit               -  id, price, percent(double), time_start(long), time_end(long)
8. Скидки             - Discount             -  id, percent, time_start(long), time_end(long)
9. Доставка           - Delivery             -  id, address(string), price, time_max(long)
10. Корзина           - Baskets              -  id, count(int), time(long), status(ENUM), total_price(double)
11. Заказ             - Order                -  id, id_user, id_baskets, id_delivery
12. Новости			  - News                 -  id, shortdescription(string), longdescription(string), time


Связки. Скорее всего в модели выносить не нужно

ПродуктАтрибут     - ProductAttribute     -  id, id_product, id_attrubute (Настя)

КомпьютерПродукт   - ComputerProduct      -  id, id_computer, id_product (Настя)

КатегорияПродукт   - CategoryProduct      -  id, id_category, id_product  (Настя)

КатегорияКомпьютер - CategoryComputer     -  id, id_category, id_computer

ПользовательРоль   - UserRoles            -  id, id_user, id_role

ПродуктСкидки      - ProductDiscount      -  id, id_product, id_discount

ПродуктКорзина     - ProductBaskets       -  id, id_product, id_baskets


Продукт может иметь несколько атрибутов. Если продукт Видеокарта, атрибуты память, скорость, потребление энергии и т.д.

Компьютер это просто набор продуктов по своей цене

Каждая категория имеет набор продуктов или компьютеров

У пользователя может быть одна или несколько ролей (фиг знает зачем несколько, и одной хватит), но связь через промежуточную таблицу всё равно. Правила для ролей убраны, хотя это менее логично.

Теперь заказ связывает юзера с корзиной, в которой будут храниться его продукты

На главной странице добавим новости, если понадобится всё таки разделить роли как раньше (используя правила) выкинем новости


