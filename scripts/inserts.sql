Use [gae]
Go

INSERT INTO FacilityCategory (facilityCategoryName)
 VALUES 
('Aula'), 
('Auditorio');

INSERT INTO Equipment (equipmentName, equipmentDescription)
VALUES 
('Cable HDMI', 'Cable con conexión HDMI.'),
('Adaptador VGA-HDMI', 'Adaptador de VGA a HDMI.'),
('Proyector', 'Proyector con entrada VGA.'),
('Equipo de sonido', 'Parlantes con entrada USB.'),
('Microfonos', 'Par de microfonos con bateria.'),
('Cable de red', 'Cable de red de 3m.');

INSERT INTO Facility (facilityName, facilityCapacity, facilityLocation, facilityCategoryIdFK)
VALUES
('B1-02', 32, 'Edificio B1, primer piso', 1),
('B1-03', 32, 'Edificio B1, primer piso', 1),
('B1-04', 32, 'Edificio B1, primer piso', 1),
('B2-02', 32, 'Edificio B2, primer piso', 1),
('B2-03', 32, 'Edificio B2, primer piso', 1),
('B2-04', 32, 'Edificio B2, primer piso', 1),
('D3-01', 75, 'Edificio D2, primer piso', 2);

INSERT INTO FacilityHasEquipment (facilityIdFK, equipmentIdFK)
VALUES 
(1,4),
(1,5),
(1,6),
(2,4),
(3,5),
(4,6),
(5,4),
(5,5),
(5,6),
(6,6);

INSERT INTO Reservation (reservationDate, reservationStartTime, reservationEndTime, reservationStatus, asociationId, delegateId, participants)
VALUES
('2023-10-02', '11:00:00', '13:00:00', 0, 'asodec@estudiantec.cr', NULL, 14),
('2023-10-02', '17:00:00', '19:00:00', 0, 'aseishla@estudiantec.cr', NULL, 11),
('2023-10-05', '11:00:00', '13:00:00', 1, 'aseidi@estudiantec.cr', 'esfrav@estudiantec.cr', 7),
('2023-10-06', '11:00:00', '13:00:00', 0, 'asoebi@estudiantec.cr', NULL, 13);

INSERT INTO ReservationHasFacility(facilityIdFK, reservationIdFK)
VALUES 
(3,1),
(4,2),
(1,3),
(6,4);
