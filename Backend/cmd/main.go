package main

import (
	"backend/controllers"
	"backend/db"
	"backend/repositories"
	"backend/services"

	"github.com/gin-gonic/gin"
)

func main() {
	server := gin.Default()

	dbConnection, err := db.ConnectDb()
	if (err!= nil){
		panic(err)
	}
	TaskRepository := repositories.NewTaskRepository(dbConnection)
	
	TaskService := services.NewTaskService(TaskRepository)

	TaskController := controllers.NewTaskController(TaskService)

	server.GET("/ping", func(ctx *gin.Context){
		ctx.JSON(200, gin.H{
			"message":"pong",
		})
	})

	server.GET("/tasks", TaskController.GetTasks)

	server.Run(":8001")
}
