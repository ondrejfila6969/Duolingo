-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Počítač: 127.0.0.1
-- Vytvořeno: Pon 10. bře 2025, 13:42
-- Verze serveru: 10.4.32-MariaDB
-- Verze PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Databáze: `duolingo`
--

-- --------------------------------------------------------

--
-- Struktura tabulky `languages`
--

CREATE TABLE `languages` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `date_created` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `date_modified` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Vypisuji data pro tabulku `languages`
--

INSERT INTO `languages` (`id`, `name`, `date_created`, `date_modified`) VALUES
(1, 'cestina', '2025-03-08 18:16:29', '2025-03-08 18:16:29'),
(2, 'anglictina', '2025-03-08 18:16:34', '2025-03-08 18:16:34'),
(3, 'rustina', '2025-03-08 18:16:37', '2025-03-08 18:16:37'),
(5, 'francouzstina', '2025-03-08 18:16:47', '2025-03-08 18:16:47'),
(6, 'rumunstina', '2025-03-10 08:49:56', '2025-03-10 08:49:56');

-- --------------------------------------------------------

--
-- Struktura tabulky `registrations`
--

CREATE TABLE `registrations` (
  `id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `language_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Vypisuji data pro tabulku `registrations`
--

INSERT INTO `registrations` (`id`, `user_id`, `language_id`) VALUES
(2, 2, 2),
(4, 3, 3),
(5, 3, 3),
(10, 5, 6),
(12, 5, 6);

-- --------------------------------------------------------

--
-- Struktura tabulky `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `date_created` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `date_modified` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Vypisuji data pro tabulku `users`
--

INSERT INTO `users` (`id`, `name`, `date_created`, `date_modified`) VALUES
(1, 'Ondra', '2025-03-08 18:14:54', '2025-03-08 18:14:54'),
(2, 'Roman', '2025-03-08 18:16:06', '2025-03-08 18:16:06'),
(3, 'Petr', '2025-03-08 18:16:11', '2025-03-08 18:16:11'),
(4, 'Bara', '2025-03-08 18:16:15', '2025-03-08 18:16:15'),
(5, 'Tomas', '2025-03-08 18:16:19', '2025-03-08 18:16:19');

--
-- Indexy pro exportované tabulky
--

--
-- Indexy pro tabulku `languages`
--
ALTER TABLE `languages`
  ADD PRIMARY KEY (`id`);

--
-- Indexy pro tabulku `registrations`
--
ALTER TABLE `registrations`
  ADD PRIMARY KEY (`id`),
  ADD KEY `user_id` (`user_id`),
  ADD KEY `language_id` (`language_id`);

--
-- Indexy pro tabulku `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT pro tabulky
--

--
-- AUTO_INCREMENT pro tabulku `languages`
--
ALTER TABLE `languages`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT pro tabulku `registrations`
--
ALTER TABLE `registrations`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT pro tabulku `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- Omezení pro exportované tabulky
--

--
-- Omezení pro tabulku `registrations`
--
ALTER TABLE `registrations`
  ADD CONSTRAINT `language_fk` FOREIGN KEY (`language_id`) REFERENCES `languages` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `user_fk` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
