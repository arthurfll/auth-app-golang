package repositories

import (
	"backend/models"
	"database/sql"
	"fmt"
)

type TaskRepository struct {
	connection *sql.DB
}

func NewTaskRepository(connection *sql.DB) TaskRepository {
	return TaskRepository{
		connection: connection,
	}
}

func (tr *TaskRepository) GetTasks() ([]models.Task, error) {
	query := "SELECT id, task_name, description FROM tasks"
	rows, err := tr.connection.Query(query)
	if err != nil {
		fmt.Println(err)
		return []models.Task{}, err
	}

	var taskList []models.Task

	for rows.Next() {
		var taskObj models.Task

		err = rows.Scan(
			&taskObj.Id,
			&taskObj.Name,
			&taskObj.Description,
		)
		if err != nil {
			fmt.Println(err)
			return []models.Task{}, err
		}

		taskList = append(taskList, taskObj)
	}
	rows.Close()

	return taskList, nil
}