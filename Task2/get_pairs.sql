select p.name as product_name,
    c.name as category_name
from products p
left join categories_products cp on p.id = cp.product_id
