using NUnit.Framework;
using FluentValidation.TestHelper;
using NDDTraining.Domain.Validations;
using NDDTraining.Domain.DTOS;
using System;


[TestFixture]
public class TrainingTestUnit
{

    private TrainingValidation validator;
    [SetUp]
    public void Setup()
    {
        validator = new TrainingValidation();
    }

    [TestCase("Curso Angular")]
    public void Validate_Title_in_TrainingDto_Sucess(string title)
    {
        var training = new TrainingDTO
        {
            Id = 1,
            Url = "jijsddj",
            Title = title,
            Description = "jdnadasida",
            Teacher = "skask",
            Duration = new System.TimeSpan(),
            Active = true,
            Category = "tech",
            ReleaseDate = new System.DateTime(1995, 10, 11)
        };
        var result = validator.TestValidate(training);
        result.ShouldNotHaveValidationErrorFor(training => training.Title);

    }
    [TestCase("")]
    public void Validate_Title_in_TrainingDto_Fail(string title)
    {
        var training = new TrainingDTO
        {
            Id = 1,
            Url = "jijsddj",
            Title = title,
            Description = "jdnadasida",
            Teacher = "skask",
            Duration = new System.TimeSpan(),
            Active = true,
            Category = "tech",
            ReleaseDate = new System.DateTime(1995, 10, 11)
        };
        var result = validator.TestValidate(training);
        result.ShouldNotHaveValidationErrorFor(training => training.Title);

    }

    [TestCase("2023,10,10")]
    public void Validate_RealaseDate_in_TrainingDto_Sucess(DateTime realaseDate)
    {
        var training = new TrainingDTO
        {
            Id = 1,
            Url = "jijsddj",
            Title = "curso x",
            Description = "jdnadasida",
            Teacher = "skask",
            Duration = new System.TimeSpan(),
            Active = true,
            Category = "tech",
            ReleaseDate = realaseDate
        };
        var result = validator.TestValidate(training);
        result.ShouldNotHaveValidationErrorFor(training => training.ReleaseDate);

    }

    [TestCase("2021,10,10")]
    public void Validate_RealaseDate_in_TrainingDto_Fail(DateTime realaseDate)
    {
        var training = new TrainingDTO
        {
            Id = 1,
            Url = "jijsddj",
            Title = "curso x",
            Description = "jdnadasida",
            Teacher = "skask",
            Duration = new System.TimeSpan(),
            Active = true,
            Category = "tech",
            ReleaseDate = realaseDate
        };
        var result = validator.TestValidate(training);
        result.ShouldNotHaveValidationErrorFor(training => training.ReleaseDate);

    }

}