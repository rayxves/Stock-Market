using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Comment;
using api.Models;

namespace api.Mappers
{
    public static class CommentMappers
    {
         public static CommentDto toCommentDto(this Comment commentModel)
        {
            return new CommentDto{
                Id = commentModel.Id,
                Title = commentModel.Title,
                Content = commentModel.Content,
                CreatedOn = commentModel.CreatedOn,
                StockId = commentModel.StockId
            };
        }

    //     public static Comment ToCommentFromCreateDTO(this createCommentsRequestDto commentDto){
    //         return new Comment{
    //             Id = commentDto.Id,
    //             Title = commentDto.Title,
    //             Content = commentDto.Content,
    //             CreatedOn = commentDto.CreatedOn,
    //             StockId = commentDto.StockId
    //         };

    } 
    
}