ALTER TABLE [Post]                  DROP CONSTRAINT [Fk_Post_UserID]

ALTER TABLE [Reshare]               DROP CONSTRAINT [Fk_Reshare_PostID]
ALTER TABLE [Reshare]               DROP CONSTRAINT [Fk_Reshare_UserID]

ALTER TABLE [LikePost]              DROP CONSTRAINT [Fk_LikePost_PostID]
ALTER TABLE [LikePost]              DROP CONSTRAINT [Fk_LikePost_UserID]

ALTER TABLE [TopShowsAndGenres]       DROP CONSTRAINT [Fk_TopShowsAndGenres_UserID]

DROP TABLE [Watcher];
DROP TABLE [Post];
DROP TABLE [Reshare];
DROP TABLE [LikePost];
DROP TABLE [TopShowsAndGenres]

-- DROP DATABASE WatchParty;