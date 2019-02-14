-- Write queries to return the following:
-- The following changes are applied to the "dvdstore" database.**

-- 1. Add actors, Hampton Avenue, and Lisa Byway to the actor table.
INSERT INTO actor(first_name, last_name)
VALUES('Hampton', 'Avenue')
INSERT INTO actor(first_name, last_name)
VALUES('Lisa', 'Byway');


-- 2. Add "Euclidean PI", "The epic story of Euclid as a pizza delivery boy in
-- ancient Greece", to the film table. The movie was released in 2008 in English.
-- Since its an epic, the run length is 3hrs and 18mins. There are no special
-- features, the film speaks for itself, and doesn't need any gimmicks.
INSERT INTO film(
      [title]
      ,[description]
      ,[release_year]
	  ,[language_id]
      ,[length])
VALUES(
	'Euclidean PI', 
	'The epic story of Euclid as a pizza delivery boy in ancient Greece', 
	2008,
	1,
	198);  

SELECT * FROM film WHERE title = 'Euclidean PI';

-- 3. Hampton Avenue plays Euclid, while Lisa Byway plays his slightly
-- overprotective mother, in the film, "Euclidean PI". Add them to the film.

INSERT INTO film_actor(actor_id, film_id)
VALUES(201, 1002)

INSERT INTO film_actor(actor_id, film_id)
VALUES(202, 1002)

SELECT * FROM film_actor WHERE film_id = 1002;

-- 4. Add Mathmagical to the category table.
INSERT INTO category(name)
VALUES('Mathmagical');

SELECT * FROM category;

-- 5. Assign the Mathmagical category to the following films, "Euclidean PI",
-- "EGG IGBY", "KARATE MOON", "RANDOM GO", and "YOUNG LANGUAGE"
INSERT INTO film_category(film_id, category_id)
VALUES (1002, 17);
UPDATE film_category
SET film_category.category_id = 17 -- Mathmagical 
WHERE film_category.film_id = 1002 OR -- Euclidean PI
	film_category.film_id = 274 OR -- EGG IGBY
	film_category.film_id = 494 OR -- KARATE MOON
	film_category.film_id = 714 OR -- RANDOM GO
	film_category.film_id = 996; -- YOUNG LANGUAGE

SELECT * FROM film_category WHERE film_category.category_id = 17;

-- 6. Mathmagical films always have a "G" rating, adjust all Mathmagical films
-- accordingly.
-- (5 rows affected)
UPDATE film
SET rating = 'G'
FROM film
JOIN film_category
ON film.film_id = film_category.film_id
WHERE film_category.category_id = 17;

SELECT * 
FROM film 
JOIN film_category
ON film.film_id = film_category.film_id
WHERE film_category.category_id = 17;

-- 7. Add a copy of "Euclidean PI" to all the stores.
INSERT INTO inventory(film_id, store_id)
VALUES (1002, 1)
INSERT INTO inventory(film_id, store_id)
VALUES (1002, 2);

SELECT * FROM inventory;

-- 8. The Feds have stepped in and have impounded all copies of the pirated film,
-- "Euclidean PI". The film has been seized from all stores, and needs to be
-- deleted from the film table. Delete "Euclidean PI" from the film table.
-- (Did it succeed? Why?)
-- <No, you cannot delete here because film_id is a FK in other tables >
DELETE
FROM film
WHERE film.title = 'Euclidean Pi'

-- 9. Delete Mathmagical from the category table.
-- (Did it succeed? Why?)
-- <No, since it is a FK in other tables>
DELETE 
FROM category
WHERE category.name = 'Mathmagical'

-- 10. Delete all links to Mathmagical in the film_category tale.
-- (Did it succeed? Why?)
-- <Yes, these are links and we are just breaking them here. The actual category_id is in the category table>
DELETE
FROM film_category
WHERE film_category.category_id = 17;


-- 11. Retry deleting Mathmagical from the category table, followed by retrying
-- to delete "Euclidean PI".
-- (Did either deletes succeed? Why?)
-- <Mathmagical : You can delete it now, since it is not used anywhere else.>
-- <Euclidean PI : No, since it is still associated with the film_actor entries we made before>
DELETE
FROM category
WHERE category.category_id = 17;

DELETE
FROM film
WHERE film.title = 'Euclidean PI';

-- 12. Check database metadata to determine all constraints of the film id, and
-- describe any remaining adjustments needed before the film "Euclidean PI" can
-- be removed from the film table.
SELECT * FROM INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE
ORDER BY COLUMN_NAME;

-- <You would have to make sure Euclidean PI is not referenced in these tables 
--  film_actor, film_category, inventory before deleting it from the film table.
--  At this point, just delete it from film_actor>

