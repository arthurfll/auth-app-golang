package controllers

import (
	"backend/services"
	"net/http"

	"github.com/gin-gonic/gin"
)

type taskController struct {
	taskService services.TaskService 
}

func NewTaskController(service services.TaskService) taskController {
	return taskController{
		taskService: service,
	}
}

func (p *taskController) GetTasks(ctx *gin.Context){

	tasks,err  := p.taskService.GetTasks()
	if(err != nil){
		ctx.JSON(http.StatusInternalServerError, err)
	}

	ctx.JSON(http.StatusOK, tasks)
}