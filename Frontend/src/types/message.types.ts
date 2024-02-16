export interface ISendMessageDTO {
  receiverUserName: string;
  text: string;
}

export interface IMessageDto extends ISendMessageDTO {
  id: number;
  senderUserName: string;
  createdAt: string;
}
