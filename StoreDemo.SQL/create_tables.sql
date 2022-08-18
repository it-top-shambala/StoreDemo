CREATE TABLE tab_types (
    type_id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
    type_name TEXT NOT NULL
);

CREATE TABLE tab_products (
    product_id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
    product_name TEXT NOT NULL,
    type_id INTEGER NOT NULL,
    is_active INTEGER NOT NULL DEFAULT 1,
    FOREIGN KEY (type_id) REFERENCES tab_types(type_id)
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);