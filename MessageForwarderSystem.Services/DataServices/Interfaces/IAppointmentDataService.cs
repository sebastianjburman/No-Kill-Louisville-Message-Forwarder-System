﻿namespace MessageForwarderSystem.Services.DataServices.Interfaces;

public interface IAppointmentDataService : IDataServiceBase<Appointment>
{
    Task CheckInToAppointment(string phoneNumber, DateTime appointmentDate);
}