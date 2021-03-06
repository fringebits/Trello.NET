﻿namespace TrelloNet
{
	public enum ActionType
	{
		CreateCard,
		CommentCard,
		UpdateCard,
        DeleteCard,
		CopyCard,
		AddMemberToCard,
		RemoveMemberFromCard,
		UpdateCheckItemStateOnCard,
		AddAttachmentToCard,
		AddChecklistToCard,
		RemoveChecklistFromCard,
		CreateList,
		UpdateList,
		CreateBoard,
		UpdateBoard,
		AddMemberToBoard,
		RemoveMemberFromBoard, 
		AddToOrganizationBoard,
		RemoveFromOrganizationBoard,
		CreateOrganization,
		UpdateOrganization,
		MoveCardToBoard,
		MoveCardFromBoard,
		ConvertToCardFromCheckItem
	}
}