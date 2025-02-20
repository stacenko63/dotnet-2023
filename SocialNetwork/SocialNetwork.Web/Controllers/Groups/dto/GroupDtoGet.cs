﻿using SocialNetwork.Domain;

namespace SocialNetwork.Web.Controllers.Groups.Dto;

/// <summary>
/// Dto группы для GET операций.
/// </summary>
public class GroupDtoGet
{
	/// <summary>	
	/// Идентификатор.	
	/// </summary>	
	public int Id { get; set; }

	/// <summary>	
	/// Название.	
	/// </summary>	
	public string Name { get; set; }

	/// <summary>	
	/// Описание.	
	/// </summary>	
	public string Description { get; set; }

	/// <summary>	
	/// Дата создания.	
	/// </summary>	
	public DateTime? CreationDate { get; set; }

	/// <summary>
	/// Идентификатор создателя.
	/// </summary>
	public int UserId { get; set; }
}
