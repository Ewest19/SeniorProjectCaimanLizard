SET IDENTITY_INSERT [Watcher] ON;
INSERT INTO [Watcher](ID, AspNetIdentityId, Username, FirstName, LastName, Email, Bio)
VALUES
(1, '571e79b0-24be-4f8b-96dd-056b493cd7c5', 'SandraHart', 'Sandra', 'Hart', 'SandraHart@email.com', NULL),
(2, '231e79b0-24be-4f8b-96dd-056b493cd7c5', 'CarsonDaniel', 'Carson', 'Daniel', 'DanielCarson@domain.net', NULL),
(3, '681e79b0-24be-4f8b-96dd-056b493cd7c5', 'PaigeCole', 'Paige', 'Cole', null, NULL),
(4, '561e79b0-24be-4f8b-96dd-056b493cd7c4', 'JaysonLawrence', 'Jayson', 'Lawrence', 'jLawrence@name.edu', NULL),
(5, '561e79b0-24be-4f8b-96dd-056b493cd7e5', 'GabrielGrant', 'Gabriel', 'Grant', 'gGabriel@differentMail.com', NULL),
(6, '561e79b0-24be-4f8b-96dd-056b493cd6c5', 'BradPorter', 'Brad', 'Porter', 'BradPorter@email.com', NULL),
(7, '561e79b0-24be-4f8b-96dd-056b493cd7p5', 'JudsonCooke', 'Judson', 'Cooke', null, NULL),
(8, '561e79b1-24be-4f8b-96dd-056b493cd7c5', 'SofiaCarpenter', 'Sofia', 'Carpenter', 'CarpenterSofia@mail.org', NULL),
(9, '561e79b0-24bf-4f8b-96dd-056b493cd7c5', 'JosefMeyer', 'Josef', 'Meyer', 'JosefMeyer@mail.edu', NULL),
(10, '561e79b0-24be-4f8b-96dd-056b593cd7c5', 'BobbieMcintyre', 'Bobbie', 'Mcintyre', null, NULL);
SET IDENTITY_INSERT [Watcher] OFF;

SET IDENTITY_INSERT [FollowingList] ON;
INSERT INTO [FollowingList](ID, UserID, FollowingID)
VALUES
(1, 1, 2),
(2, 1, 3),
(3, 1, 4),
(4, 1, 5),
(5, 1, 6),
(6, 1, 7),
(7, 1, 8),
(8, 1, 9),
(9, 1, 10),
(10, 2, 1),
(11, 2, 3),
(12, 2, 5),
(13, 2, 7),
(14, 2, 9),
(15, 3, 2),
(16, 3, 4),
(17, 3, 6),
(18, 3, 8),
(19, 3, 10),
(20, 4, 3),
(21, 4, 6),
(22, 4, 9),
(23, 5, 3),
(24, 5, 4),
(25, 5, 6),
(26, 5, 7),
(27, 5, 8),
(28, 5, 9),
(29, 5, 10),
(30, 6, 3),
(31, 6, 5),
(32, 6, 7),
(33, 6, 9),
(34, 7, 3),
(35, 7, 2),
(36, 7, 4),
(37, 7, 6),
(38, 7, 8),
(39, 7, 10),
(40, 8, 3),
(41, 8, 7),
(42, 8, 10),
(43, 9, 1),
(44, 9, 3),
(45, 9, 5),
(46, 9, 7),
(47, 9, 10);
SET IDENTITY_INSERT [FollowingList] OFF;

SET IDENTITY_INSERT [Post] ON;
INSERT INTO [Post](ID, PostTitle, PostDescription, DatePosted, UserID)
VALUES
(1, 'That new Ant-man movie was incredible!', null, '2023-01-15 17:00:00', 1),
(2, 'Spider-man', 'So excited for the new spider man movies!', '2023-02-01 15:00:00', 3),
(3, 'Friends', 'By far one of my favorite shows', '2023-02-08 08:00:00', 5),
(4, 'Best comedy of 2023?', null, '2022-12-25 12:00:00', 7),
(5, 'Might have been the best movie released in a while', null, '2023-02-03 13:00:00', 2),
(6, 'Who wants to watch a movie later', null, '2023-01-15 17:00:00', 6),
(7, 'The office was a good show', 'It was increible unlike anything else I''ve seen before', '2023-01-15 17:00:00', 9),
(8, 'Friends with friends', null, '2023-01-15 17:00:00', 10),
(9, 'MCU marathon', 'Who is down to have a MCU marathon sometime next week?', '2023-01-15 17:00:00', 8),
(10, 'Avatar', 'Excited to watch the new Avatar movie that came out', '2023-01-15 17:00:00', 4)
SET IDENTITY_INSERT [Post] OFF;

SET IDENTITY_INSERT [Reshare] ON;
INSERT INTO [Reshare] (ID, PostID, UserID)
VALUES
(1, 1, 2),
(2, 1, 5),
(3, 2, 7),
(4, 2, 10),
(5, 3, 6),
(6, 3, 8),
(7, 4, 1),
(8, 4, 2),
(9, 5, 3),
(10, 5, 5),
(11, 6, 9),
(12, 6, 7),
(13, 7, 10),
(14, 7, 5),
(15, 8, 3),
(16, 8, 5),
(17, 9, 1),
(18, 9, 9),
(19, 10, 7),
(20, 10, 3)
SET IDENTITY_INSERT [Reshare] OFF;

SET IDENTITY_INSERT [LikePost] ON;
INSERT INTO [LikePost] (ID, PostID, UserID)
VALUES
(1, 1, 2),
(2, 1, 5),
(3, 2, 7),
(4, 2, 10),
(5, 3, 6),
(6, 3, 8),
(7, 4, 1),
(8, 4, 2),
(9, 5, 3),
(10, 5, 5),
(11, 6, 9),
(12, 6, 7),
(13, 7, 10),
(14, 7, 5),
(15, 8, 3),
(16, 8, 5),
(17, 9, 1),
(18, 9, 9),
(19, 10, 7),
(20, 10, 3)
SET IDENTITY_INSERT [LikePost] OFF;