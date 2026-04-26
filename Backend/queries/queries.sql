CREATE TABLE tasks (
	id SERIAL PRIMARY KEY,
	task_name VARCHAR(50) NOT NULL,
	description VARCHAR(200) NOT NULL
);

SELECT * FROM "tasks"


INSERT INTO "tasks"(task_name, description) VALUES('Pensar no nome','ter um nome para o app')

