# Healthcare Appointment System
## Overview
The Healthcare Appointment System is designed to streamline the scheduling and management of appointments between patients and healthcare providers. This system offers a convenient way for users to book appointments, receive reminders, and manage their medical records. Healthcare providers can efficiently schedule appointments, access patient records, and send appointment reminders.

## Features
- **Appointment Booking**: Patients can book appointments with their preferred healthcare providers.
- **Appointment Scheduling**: Patients can select an available date and schedule an appointment. Healthcare providers can then review the request, choose to accept or decline the appointment, or ask the patient to reschedule for a different time or day slot.
- **Reminders**: Automated reminders for patients about upcoming appointments.
- **Patient Records**: Secure storage and retrieval of patient medical records.
- **Admin Dashboard**: Admin users can oversee the entire system, manage users, and monitor appointments.


## Microservices Architecture
This application is split into multiple microservices:

1. **Healthcare Appointment System (Core Application)**:
   - Manages the booking of appointments.
   - Securely stores patient records.
   - Collects feedback from patients regarding their appointments.

2. **Admin and User Dashboards**:
   - **Admin Dashboard**: Allows administrators to manage appointments and handle user management.
   - **User Dashboard**: Enables users to view, reschedule, or cancel their appointments.

3. **Reminders Microservice**:
   - Generates automated reminders (via email, SMS, or in-app notifications) based on the Healthcare Appointment System.

4. **Identity Management**:
   - Manages authentication and authorization for all users.
   - Serves as the entry point for the rest of the application.
  
