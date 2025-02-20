﻿namespace SocialNetwork.Domain;

/// <summary>	
/// Запись.	
/// </summary>	
public class Note
{	
    /// <summary>	
    /// Идентификатор.	
    /// </summary>	
    public int Id { get; set; }

    /// <summary>	
    /// Название.	
    /// </summary>	
    public string Name { get; set; } = string.Empty;

    /// <summary>	
    /// Описание.	
    /// </summary>	
    public string Description { get; set; } = string.Empty;

    /// <summary>	
    /// Дата создания.	
    /// </summary>	
    public DateTime? CreationDate { get; set; }

    /// <summary>
    /// Идентификатор автора.
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// Автор.
    /// </summary>
    public User? User { get; set; }

    /// <summary>
    /// Идентификатор группы.
    /// </summary>
    public int GroupId { get; set; }

    /// <summary>
    /// Группа.
    /// </summary>
    public Group? Group { get; set; }

	public Note(int id, string name, string description, DateTime? creationDate, int userId,
		User? user, int groupId, Group? group)
	{
		Id = id;
		Name = name;
		Description = description;
		CreationDate = creationDate;
		UserId = userId;
		User = user;
		GroupId = groupId;
		Group = group;
	}

	public Note()
	{
	}
}