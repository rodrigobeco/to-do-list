CREATE TABLE todo (
    id SERIAL PRIMARY KEY,
    title VARCHAR(100) NOT NULL,
    content VARCHAR(255) NOT NULL,
    completed BIT NOT NULL
);