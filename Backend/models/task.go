package models

type Task struct {
	Id int             `json:"id_task"`
	Name string        `json:"name"`
	Description string `json:"description"`
}

