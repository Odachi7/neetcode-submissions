CREATE TABLE videos (
    id integer,
    name text DEFAULT 'Untitled',
    is_published boolean DEFAULT false
); 







-- Do not modify below this line --
INSERT INTO videos (id, name, is_published) 
VALUES (1, 'My Video', true),
       (2, 'Another Video', false);

INSERT INTO videos (id)
VALUES (3),
       (4);

INSERT INTO videos (name)
VALUES ('Video with no ID');

SELECT * FROM videos;
