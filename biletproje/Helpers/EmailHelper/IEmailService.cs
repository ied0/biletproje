namespace biletproje.Helpers.EmailSenderHelper
{
	public interface IEmailService
	{
		Task Send(EmailModel message);
	}
}