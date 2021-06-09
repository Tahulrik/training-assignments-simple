public class BuildAndSendMail {
    public void buildAndSendMail(MailRecipient recipient,
        MailMessage message) {

        MailSender mailMan = new MailSender();

        mailMan.send(subject, mMessage);
    }

    

    private class MailSender {
        public void send(MailRecipient recipient, MailMessage message) {}
    }

    private class MailFont {

    }

    private class MailMessage {

        MailFont fontType;
        string subject;
        List<string> messages;
        private void formatMessage() {
            return null;
        }
    }

    private class MailRecipient
    {
        public string mailAddress { get; private set;}
        string firstName {get;}
        string lastName {get;}
        private string division;

        public MailRecipient(string firstName, string lastName, string division)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.division = division;

            formatMailAdress();
        }

        private formatMailAddress()
        {
            return mailAddress = firstName.charAt(0) + "." + lastName.substring(0, 7) + "@"
            + division.substring(0, 5) + ".compa.ny";
        }

    }
}