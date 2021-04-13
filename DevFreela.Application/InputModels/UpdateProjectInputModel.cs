﻿namespace DevFreela.Application.InputModels
{
    public class UpdateProjectInputModel
    {
        public int Id { get; private set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal TotalCost { get; set; }
    }
}
