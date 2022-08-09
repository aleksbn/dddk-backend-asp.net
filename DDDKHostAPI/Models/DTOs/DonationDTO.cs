﻿namespace DDDKHostAPI.Models.DTOs
{
    public class CreateDonationDTO
    {
        public int DonatorId { get; set; }
        public int DonationEventId { get; set; }
    }

    public class DonationDTO: CreateDonationDTO
    {
        public int Id { get; set; }
        public DonatorDTO Donator { get; set; }
        public DonationEventDTO DonationEvent { get; set; }
    }
}
