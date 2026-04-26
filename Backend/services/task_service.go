package services

import (
	"backend/models"
	"backend/repositories"
)

type TaskService struct {
	repository repositories.TaskRepository
}

func NewTaskService(repository repositories.TaskRepository) TaskService {
	return TaskService{
		repository:repository,
	}
}

func (ts *TaskService) GetTasks() ([]models.Task, error){
	return ts.repository.GetTasks()
}