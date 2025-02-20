﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SocialNetwork.Data.Models;

/// <summary>
/// Модель группы.
/// </summary>
[Table("group")]
public class GroupDbModel 
{
	/// <summary>
	/// Идентификатор.
	/// </summary>
	[Column("id")]
	[Key]
	public int Id { get; set; }

	/// <summary>
	/// Название.
	/// </summary>
	[Column("name")]
	[Required]
	public string Name { get; set; }

	/// <summary>
	/// Описание.
	/// </summary>
	[Column("description")]
	[Required]
	public string Description { get; set; }

	/// <summary>
	/// Дата создания.
	/// </summary>
	[Column("creation_date")]
	[Required]
	public DateTime? CreationDate { get; set; }

	/// <summary>
	/// Идентификатор создателя.
	/// </summary>
	[Column("user_id")]
	[Required]
	public int UserId { get; set; }

	/// <summary>
	/// Создатель.
	/// </summary>
	public UserDbModel User { get; set; }
}
