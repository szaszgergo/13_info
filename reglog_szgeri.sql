-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2024. Okt 07. 11:53
-- Kiszolgáló verziója: 10.4.6-MariaDB
-- PHP verzió: 7.3.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `reglog_szgeri`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `login`
--

CREATE TABLE `login` (
  `lid` int(11) NOT NULL,
  `ldate` datetime NOT NULL,
  `lip` varchar(49) COLLATE utf16_hungarian_ci NOT NULL,
  `lsession` varchar(8) COLLATE utf16_hungarian_ci NOT NULL,
  `luid` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf16 COLLATE=utf16_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `note`
--

CREATE TABLE `note` (
  `nid` int(11) NOT NULL,
  `ndate` datetime NOT NULL,
  `nip` varchar(49) COLLATE utf16_hungarian_ci NOT NULL,
  `nsession` varchar(8) COLLATE utf16_hungarian_ci NOT NULL,
  `nuid` int(11) NOT NULL,
  `nurl` varchar(255) COLLATE utf16_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf16 COLLATE=utf16_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `user`
--

CREATE TABLE `user` (
  `uid` int(11) NOT NULL,
  `uemail` varchar(255) COLLATE utf16_hungarian_ci NOT NULL,
  `unick` varchar(100) COLLATE utf16_hungarian_ci NOT NULL,
  `upw` varchar(64) COLLATE utf16_hungarian_ci NOT NULL,
  `ubirth` date NOT NULL,
  `udate` datetime NOT NULL,
  `uip` varchar(49) COLLATE utf16_hungarian_ci NOT NULL,
  `usession` varchar(8) COLLATE utf16_hungarian_ci NOT NULL,
  `ustatus` varchar(5) COLLATE utf16_hungarian_ci NOT NULL,
  `ucomment` text COLLATE utf16_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf16 COLLATE=utf16_hungarian_ci;

--
-- A tábla adatainak kiíratása `user`
--

INSERT INTO `user` (`uid`, `uemail`, `unick`, `upw`, `ubirth`, `udate`, `uip`, `usession`, `ustatus`, `ucomment`) VALUES
(1, '', '', '', '0000-00-00', '0000-00-00 00:00:00', '', '', '', ''),
(2, '$_POST[email]', '$POST_[user]', '$upw', '0000-00-00', '2024-09-30 13:09:53', '', '', '', ''),
(5, 'asd@gmail.com', 'asd', 'd41d8cd98f00b204e9800998ecf8427e', '2024-10-05', '2024-09-30 13:13:40', '', '', '', ''),
(6, 'asd@gmail.com', 'asd', 'd41d8cd98f00b204e9800998ecf8427e', '0000-00-00', '2024-09-30 13:50:03', '', '', '', ''),
(7, 'asd@gmail.com', 'asd', '7815696ecbf1c96e6894b779456d330e', '0000-00-00', '2024-09-30 13:50:40', '', '', '', ''),
(8, 'asd@gmail.com', 'asd', '7815696ecbf1c96e6894b779456d330e', '0000-00-00', '2024-09-30 13:51:38', '', '', '', ''),
(9, 'asd@gmail.com', 'asd', '7815696ecbf1c96e6894b779456d330e', '0000-00-00', '2024-09-30 13:52:04', '', '', '', ''),
(10, 'asd@gmail.com', 'asd', '7815696ecbf1c96e6894b779456d330e', '0000-00-00', '2024-09-30 13:52:05', '', '', '', ''),
(11, 'asd@gmail.com', 'asd', '7815696ecbf1c96e6894b779456d330e', '0000-00-00', '2024-09-30 13:52:17', '', '', '', ''),
(12, 'asd@gmail.com', 'asd', '7815696ecbf1c96e6894b779456d330e', '0000-00-00', '2024-09-30 13:52:53', '', '', '', ''),
(13, 'asd@gmail.com', 'asd', '7815696ecbf1c96e6894b779456d330e', '0000-00-00', '2024-09-30 13:53:59', '', '', '', ''),
(14, 'asd@gmail', 'asd', 'b173bc8223f3b8a819599449aa1fd53e', '2024-09-26', '2024-09-30 14:02:47', '', '', '', ''),
(15, 'asd@gmail', 'asd', 'b173bc8223f3b8a819599449aa1fd53e', '2024-09-26', '2024-09-30 14:02:48', '', '', '', ''),
(16, 'asd@gmail', 'asd', 'b173bc8223f3b8a819599449aa1fd53e', '2024-09-26', '2024-09-30 14:02:49', '', '', '', ''),
(17, 'asd@gmail', 'asd', 'b173bc8223f3b8a819599449aa1fd53e', '2024-09-26', '2024-09-30 14:02:49', '', '', '', ''),
(18, 'asd@gmail', 'asd', 'b173bc8223f3b8a819599449aa1fd53e', '2024-09-26', '2024-09-30 14:02:50', '', '', '', ''),
(19, 'asd@gmail', 'asd', 'b173bc8223f3b8a819599449aa1fd53e', '2024-09-26', '2024-09-30 14:02:50', '', '', '', ''),
(20, 'asd@asd.hu', 'asd', '6728a0e19503d6c7b66cb522fcf58348', '2024-10-24', '2024-10-02 14:21:39', '', '', '', ''),
(21, 'asd@gmail.com', 'asd', 'f67c2bcbfcfa30fccb36f72dca22a817', '2024-10-26', '2024-10-03 10:31:45', '', '', '', ''),
(22, 'gerike@gmail.com', 'gerike', 'e117606e21e4f198768714a438c7cef4', '2024-10-25', '2024-10-03 11:09:32', '', '', '', ''),
(23, 'gerike@gmail.com', 'gerike', 'e117606e21e4f198768714a438c7cef4', '2024-10-25', '2024-10-03 11:09:39', '', '', '', ''),
(24, 'gerike@gmail.com', 'gerike', 'e117606e21e4f198768714a438c7cef4', '2024-10-25', '2024-10-03 11:09:39', '', '', '', ''),
(25, 'gerike@gmail.com', 'gerike', 'e117606e21e4f198768714a438c7cef4', '2024-10-02', '2024-10-03 11:11:12', '', '', '', ''),
(26, 'gerike@gmail.com', 'gerike', 'e117606e21e4f198768714a438c7cef4', '2024-10-02', '2024-10-03 11:13:42', '', '', '', '');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`lid`);

--
-- A tábla indexei `note`
--
ALTER TABLE `note`
  ADD PRIMARY KEY (`nid`);

--
-- A tábla indexei `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`uid`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `login`
--
ALTER TABLE `login`
  MODIFY `lid` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `note`
--
ALTER TABLE `note`
  MODIFY `nid` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `user`
--
ALTER TABLE `user`
  MODIFY `uid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
