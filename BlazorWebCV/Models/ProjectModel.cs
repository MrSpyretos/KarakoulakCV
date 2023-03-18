﻿
namespace BlazorWebCV.Models;

public readonly record struct ProjectModel(string Title,
    string Image,
    string Description,
    string PopupDescription,
    string Repository,
    int Order);
