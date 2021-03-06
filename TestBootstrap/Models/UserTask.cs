﻿using System.ComponentModel.DataAnnotations;

namespace DiaryAppOlga.Models
{
    //public enum Priorities
    //{
    //    High, Medium, Low
    //}

    public class UserTask
    {

        //???
        //public string UserId { get; set; }     
               
        public int Id { get; set; }
        

        [Required(ErrorMessage = "Set a task.")]
        [Display(Name = "Task")]                     
        [StringLength(50, MinimumLength = 10, ErrorMessage = "Task length must be between 10 and 50 characters!")]
        public string TaskName { get; set; }        

        [Required(ErrorMessage = "Add a description for the task. No more than 500 characters!")]
        [Display(Name = "Description")]
        [StringLength(500)]
        public string Description { get; set; }


        //[Required(ErrorMessage = "Set a priority for the task!")]
        //[Display(Name = "Priority")]
        //public Priority Priority { get; set; }

        public bool Status { get; private set; }

        //[Required(ErrorMessage = "Set a priority for the task!")]
        //[Display(Name = "Priority")]
        //public Priorities? Priorities { get; set; }


        // public Grade Grade { get; set; }


    }
}
