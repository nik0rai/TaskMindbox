select p.name as product_name,
    c.name as category_name
from products p
join categories_products cp on p.id = cp.product_id
join categories c on cp.category_id = c.id
group by p.id
having count(c.id) > 0;