--
-- PostgreSQL database dump
--

-- Dumped from database version 16.2
-- Dumped by pg_dump version 16.2

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- Name: product_category; Type: TYPE; Schema: public; Owner: postgres
--

CREATE TYPE public.product_category AS ENUM (
    'fruit',
    'vegetable',
    'breadstuff',
    'meat',
    'drink',
    'dairy',
    'sweet',
    'frozen food',
    'alcohol',
    'energy drink',
    'energy_drink',
    'frozen_food'
);


ALTER TYPE public.product_category OWNER TO postgres;

--
-- Name: add_product(character varying, double precision, double precision, integer, character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.add_product(_product_name character varying, _price double precision, _weight double precision, _barcode integer, _product_type character varying) RETURNS void
    LANGUAGE plpgsql
    AS $$
BEGIN
    INSERT INTO products (product_name, price, weight, barcode, product_type)
    VALUES (_product_name, _price, _weight, _barcode, _product_type);
END;
$$;


ALTER FUNCTION public.add_product(_product_name character varying, _price double precision, _weight double precision, _barcode integer, _product_type character varying) OWNER TO postgres;

--
-- Name: delete_product(integer); Type: PROCEDURE; Schema: public; Owner: postgres
--

CREATE PROCEDURE public.delete_product(IN _id integer)
    LANGUAGE plpgsql
    AS $$
BEGIN
  DELETE FROM products WHERE id = _id;
END;
$$;


ALTER PROCEDURE public.delete_product(IN _id integer) OWNER TO postgres;

--
-- Name: get_all_products(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.get_all_products() RETURNS TABLE(id integer, product_name character varying, price double precision, weight double precision, barcode integer, product_type character varying)
    LANGUAGE plpgsql
    AS $$
BEGIN
    RETURN QUERY SELECT * FROM products
	ORDER BY id;
END;
$$;


ALTER FUNCTION public.get_all_products() OWNER TO postgres;

--
-- Name: get_product_by_id(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.get_product_by_id(product_id integer) RETURNS TABLE(id integer, product_name character varying, price double precision, weight double precision, barcode integer, product_type character varying)
    LANGUAGE plpgsql
    AS $$
DECLARE
    product_cursor CURSOR FOR
        SELECT 
            p.id AS product_id,
            p.product_name,
            p.price,
            p.weight,
            p.barcode,
            p.product_type
        FROM products p
        WHERE p.id = product_id;
    product_record RECORD;
BEGIN
    OPEN product_cursor;

    LOOP
        FETCH product_cursor INTO product_record;
        EXIT WHEN NOT FOUND;

        id := product_record.product_id;
        product_name := product_record.product_name;
        price := product_record.price;
        weight := product_record.weight;
        barcode := product_record.barcode;
        product_type := product_record.product_type;

        RETURN NEXT;
    END LOOP;

    CLOSE product_cursor;
END;
$$;


ALTER FUNCTION public.get_product_by_id(product_id integer) OWNER TO postgres;

--
-- Name: prod_stamp(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.prod_stamp() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
  BEGIN
    IF NEW.product_name IS NULL OR NEW.product_name = '' THEN
      RAISE EXCEPTION 'product name cannot be null';
    END IF;
    IF NEW.price IS NULL THEN
      RAISE EXCEPTION '% cannot have null price', NEW.product_name;
    END IF;
    IF NEW.price < 0 THEN
      RAISE EXCEPTION '% cannot have a negative price', NEW.product_name;
    END IF;
    IF NEW.weight IS NULL THEN
      RAISE EXCEPTION '% cannot have null weight', NEW.product_name;
    END IF;
    IF NEW.weight < 0 THEN
      RAISE EXCEPTION '% cannot have a negative weight', NEW.product_name;
    END IF;
    IF NEW.barcode < 100000 OR NEW.barcode > 999999 THEN
      RAISE EXCEPTION '% must have a 6-digit barcode', NEW.product_name;
    END IF;
    IF EXISTS (SELECT 1 FROM products WHERE barcode = NEW.barcode AND id != NEW.id) THEN
      RAISE EXCEPTION 'Barcode % already exists', NEW.barcode;
    END IF;
    IF NEW.barcode IS NULL THEN
      RAISE EXCEPTION '% cannot have null barcode', NEW.product_name;
    END IF;
    IF NEW.product_type IS NULL OR NEW.product_type = '' THEN
      RAISE EXCEPTION '% cannot have null product type', NEW.product_name;
    END IF;
    RETURN NEW;
  END;
$$;


ALTER FUNCTION public.prod_stamp() OWNER TO postgres;

--
-- Name: update_product(integer, character varying, double precision, double precision, integer, character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.update_product(_id integer, _product_name character varying, _price double precision, _weight double precision, _barcode integer, _product_type character varying) RETURNS void
    LANGUAGE plpgsql
    AS $$
BEGIN
    UPDATE products
    SET product_name = _product_name,
        price = _price,
        weight = _weight,
        barcode = _barcode,
        product_type = _product_type
    WHERE id = _id;
END;
$$;


ALTER FUNCTION public.update_product(_id integer, _product_name character varying, _price double precision, _weight double precision, _barcode integer, _product_type character varying) OWNER TO postgres;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: customers; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.customers (
    id integer NOT NULL,
    name character varying NOT NULL,
    surname character varying NOT NULL,
    phone_number character varying NOT NULL,
    email character varying NOT NULL
);


ALTER TABLE public.customers OWNER TO postgres;

--
-- Name: customers_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.customers_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.customers_id_seq OWNER TO postgres;

--
-- Name: customers_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.customers_id_seq OWNED BY public.customers.id;


--
-- Name: employees; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.employees (
    id integer NOT NULL,
    name character varying NOT NULL,
    surname character varying NOT NULL,
    phone_number character varying NOT NULL,
    email character varying NOT NULL,
    access_code integer NOT NULL,
    employee_type character varying
);


ALTER TABLE public.employees OWNER TO postgres;

--
-- Name: employees_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.employees_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.employees_id_seq OWNER TO postgres;

--
-- Name: employees_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.employees_id_seq OWNED BY public.employees.id;


--
-- Name: products; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.products (
    id integer NOT NULL,
    product_name character varying NOT NULL,
    price double precision NOT NULL,
    weight double precision NOT NULL,
    barcode integer NOT NULL,
    product_type character varying NOT NULL
);


ALTER TABLE public.products OWNER TO postgres;

--
-- Name: COLUMN products.weight; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.products.weight IS 'weight in grams';


--
-- Name: products_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.products_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.products_id_seq OWNER TO postgres;

--
-- Name: products_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.products_id_seq OWNED BY public.products.id;


--
-- Name: transaction_items; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.transaction_items (
    id integer NOT NULL,
    quantity integer NOT NULL,
    amount double precision NOT NULL,
    product_fk integer NOT NULL,
    transaction_fk integer NOT NULL
);


ALTER TABLE public.transaction_items OWNER TO postgres;

--
-- Name: transaction_items_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.transaction_items_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.transaction_items_id_seq OWNER TO postgres;

--
-- Name: transaction_items_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.transaction_items_id_seq OWNED BY public.transaction_items.id;


--
-- Name: transactions; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.transactions (
    id integer NOT NULL,
    date timestamp without time zone NOT NULL,
    total_amount double precision NOT NULL,
    employees_fk integer,
    customer_fk integer
);


ALTER TABLE public.transactions OWNER TO postgres;

--
-- Name: transactions_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.transactions_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.transactions_id_seq OWNER TO postgres;

--
-- Name: transactions_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.transactions_id_seq OWNED BY public.transactions.id;


--
-- Name: customers id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.customers ALTER COLUMN id SET DEFAULT nextval('public.customers_id_seq'::regclass);


--
-- Name: employees id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.employees ALTER COLUMN id SET DEFAULT nextval('public.employees_id_seq'::regclass);


--
-- Name: products id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.products ALTER COLUMN id SET DEFAULT nextval('public.products_id_seq'::regclass);


--
-- Name: transaction_items id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.transaction_items ALTER COLUMN id SET DEFAULT nextval('public.transaction_items_id_seq'::regclass);


--
-- Name: transactions id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.transactions ALTER COLUMN id SET DEFAULT nextval('public.transactions_id_seq'::regclass);


--
-- Data for Name: customers; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.customers (id, name, surname, phone_number, email) FROM stdin;
17	Magdalena	Smedmore	232 456 873	msmedmoreg@jimdo.com
6	Dag	Shillaber	544 955 644	dshillaber5@symantec.com
11	Yulma	Radolf	923 549 336	yradolfa@lulu.com
3	Catie	Struss	936 827 963	cstruss2@elegantthemes.com
26	Jarad	Riseley	990 764 792	jriseleyp@desdev.cn
28	Filip	Blackler	287 773 377	fblacklerr@webeden.co.uk
2	Lovell	Cordaroy	679 280 956	lcordaroy1@mail.ru
7	Chaunce	Lauxmann	365 373 296	clauxmann6@etsy.com
23	Etta	Cowthart	235 245 270	ecowthartm@abc.net.au
19	Hamid	Katz	631 899 111	hkatzi@tinyurl.com
18	Branden	Graver	454 611 697	bgraverh@zimbio.com
9	Janos	Bates	185 413 232	jbates8@statcounter.com
29	Verney	Whapham	544 919 013	vwhaphams@tmall.com
25	Francois	Lantiffe	279 961 903	flantiffeo@wix.com
1	Bernice	McNeachtain	740 338 315	bmcneachtain0@washington.edu
10	Kirstyn	Suggey	974 103 243	ksuggey9@google.cn
20	Maddy	Branney	176 616 704	mbranneyj@nifty.com
14	Robin	Van Salzberger	298 347 619	rvansalzbergerd@biglobe.ne.jp
24	Kelly	Maestrini	725 628 607	kmaestrinin@tamu.edu
8	Kellie	Newis	869 590 488	knewis7@photobucket.com
21	Andonis	Imlach	816 238 696	aimlachk@aol.com
4	Pernell	Redholls	439 211 728	predholls3@npr.org
12	Avigdor	Pragnall	361 948 560	apragnallb@state.tx.us
22	Noam	Finlaison	122 957 687	nfinlaisonl@drupal.org
16	Deck	Bedenham	965 924 110	dbedenhamf@earthlink.net
13	Rafael	Rollingson	772 222 311	rrollingsonc@symantec.com
15	Isidore	Anshell	911 843 051	ianshelle@creativecommons.org
30	Bili	Rump	405 142 491	brumpt@prweb.com
27	Reinaldos	Burden	493 758 981	rburdenq@feedburner.com
5	Laney	Berzins	193 512 984	lberzins4@angelfire.com
31	Adam	Kowalski	123 123 123	example@test.com
\.


--
-- Data for Name: employees; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.employees (id, name, surname, phone_number, email, access_code, employee_type) FROM stdin;
1	Frederico	Goundry	480 560 360	fgoundry0@buzzfeed.com	1621	admin
2	Mohandas	Sconce	929 706 299	msconce1@house.gov	2787	cashier
3	Camellia	Wyld	119 905 695	cwyld2@mayoclinic.com	1774	cashier
4	Adams	Salthouse	297 905 636	asalthouse3@webnode.com	2820	cashier
5	Arturo	Boyland	372 448 327	aboyland4@msn.com	9815	cashier
6	Olivier	Beseke	198 963 246	obeseke5@bizjournals.com	8138	cashier
7	Ginnifer	Fockes	620 609 879	gfockes6@craigslist.org	5905	cashier
8	Franciska	Sieghard	233 499 920	fsieghard7@php.net	5809	cashier
9	Vivienne	Lardez	725 622 110	vlardez8@apache.org	8689	cashier
10	Cilka	Christie	279 304 603	cchristie9@usa.gov	1811	cashier
11	Karly	Riccelli	145 848 775	kriccellia@google.pl	4950	cashier
12	Demott	Paladino	165 161 339	dpaladinob@narod.ru	6164	cashier
13	Nike	Hellings	602 623 143	nhellingsc@smh.com.au	9680	cashier
14	Aindrea	Isaksson	580 261 010	aisakssond@surveymonkey.com	9443	cashier
15	Cindra	Scriviner	133 938 937	cscrivinere@archive.org	2509	cashier
16	Karilynn	Cardoso	436 951 412	kcardosof@netlog.com	6918	cashier
17	Collin	Bowser	168 378 226	cbowserg@sbwire.com	8760	cashier
18	George	Salvador	231 989 247	gsalvadorh@twitpic.com	9773	cashier
19	Fleur	Faulkes	504 244 274	ffaulkesi@dropbox.com	1285	cashier
20	Ban	Budnk	665 802 715	bbudnkj@theglobeandmail.com	9675	cashier
21	Kathi	Baber	540 864 598	kbaberk@tinypic.com	3709	cashier
22	Tyrus	Bechley	663 960 490	tbechleyl@fotki.com	9378	cashier
23	Leroy	Leys	984 699 767	lleysm@163.com	9492	cashier
24	Lizette	Bowes	408 890 545	lbowesn@ifeng.com	6307	cashier
25	Parker	Lydiatt	984 142 552	plydiatto@ucoz.ru	2083	cashier
26	Bastian	Morecomb	185 949 916	bmorecombp@hp.com	2495	admin
27	Audy	Ackhurst	494 452 402	aackhurstq@auda.org.au	6600	cashier
28	Evvie	Swalough	860 850 087	eswaloughr@youtube.com	2257	cashier
29	Peria	Heasly	741 798 153	pheaslys@furl.net	4122	cashier
30	Linell	Barkworth	256 437 343	lbarkwortht@trellian.com	3209	cashier
\.


--
-- Data for Name: products; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.products (id, product_name, price, weight, barcode, product_type) FROM stdin;
48	Multigrain Bread	2.2	450	365847	breadstuff
50	Focaccia	1.6	150	308762	breadstuff
1	Apple	0.45	150	575448	fruit
2	Banana	0.25	120	633119	fruit
3	Orange	0.55	200	800798	fruit
5	Grapes	3	500	905518	fruit
8	Peach	0.7	180	823453	fruit
7	Pineapple	2	1500	354329	fruit
6	Watermelon	4.5	5000	870407	fruit
4	Strawberry	1.8	100	457303	fruit
14	Blueberry	3	150	997642	fruit
18	Papaya	1.8	1000	421294	fruit
15	Blackberry	2	100	625204	fruit
13	Raspberry	3.5	200	185935	fruit
9	Pear	0.65	180	868494	fruit
12	Plum	0.5	80	922119	fruit
11	Kiwi	0.6	100	892871	fruit
20	Lychee	3.5	250	859806	fruit
19	Guawa	1.3	250	546329	fruit
16	Cherry	1	100	176228	fruit
17	Apricot	0.9	150	934182	fruit
10	Mango	1.3	300	893834	fruit
25	Lettuce	0.5	150	537673	vegetable
23	Potato	0.15	200	389921	vegetable
26	Cucumber	0.4	200	597570	vegetable
24	Onion	0.25	100	444784	vegetable
21	Carrot	0.2	100	659736	vegetable
22	Tomato	0.3	150	560425	vegetable
33	Green Beans	0.55	100	173096	vegetable
38	Pumpkin	2	3000	853646	vegetable
32	Eggplant	0.75	250	605855	vegetable
34	Asparagus	1.2	150	158461	vegetable
36	Mushroom	0.99	200	992923	vegetable
35	Radish	0.35	50	919904	vegetable
27	Bell peper	0.6	150	356971	vegetable
31	Zucchini	0.45	150	438997	vegetable
29	Broccoli	0.8	250	124088	vegetable
28	Spinach	0.7	100	281641	vegetable
39	Sweet Potato	0.5	250	119800	vegetable
30	Cauliflower	1	300	807966	vegetable
40	Celery	0.55	100	881488	vegetable
37	Cabbage	0.65	300	599079	vegetable
44	Rye Bread	1.7	400	947755	breadstuff
43	Ciabatta	1.8	200	755278	breadstuff
49	Bagel	0.8	100	842903	breadstuff
41	Baguette	1.5	250	913360	breadstuff
42	Whole Wheat Bread	2	500	983200	breadstuff
47	Pita Bread	0.6	80	334610	breadstuff
46	Sourdough Bread	2.5	600	780417	breadstuff
51	Wheat roll	0.3	65	201922	breadstuff
45	Croissant	0.9	100	763927	breadstuff
53	Chicken	0.5	100	385299	meat
54	Beef	3.5	100	385132	meat
55	Pork	2	100	385543	meat
56	Veal	4	100	567234	meat
57	Lamb	5	100	765234	meat
58	Duck	2.5	100	655423	meat
59	Turkey	1.8	100	321654	meat
60	Rabbit	3.2	100	543654	meat
61	Salmon	2.8	100	128904	meat
62	Tuna	4.5	100	893421	meat
63	Mineral Water	0.5	500	123631	drink
64	Orange Juice	1.2	1000	481965	drink
65	Super Cola - can	2	330	651864	drink
66	Super Cola - bottle	4.99	1500	165024	drink
67	Green Tea	0.8	480	654165	drink
68	Instant Coffee	3.5	200	745234	drink
69	Apple Juice	1	1000	978034	drink
70	Fruit Smoothie	2.5	500	673892	drink
71	Alcohol Free Beer - glass bottle	3.99	600	923411	drink
72	Alcohol Free Beer - can	2.99	400	512374	drink
75	Milk	1	1000	789234	dairy
76	Yogurt	0.8	200	124356	dairy
77	Cheddar Cheese	8.99	300	654211	dairy
78	Gouda Cheese	10.5	500	712345	dairy
79	Butter	1.2	100	654123	dairy
80	Greek Yogurt	1.2	130	612367	dairy
81	Mozzarella Cheese	5	200	762345	dairy
82	Cream	0.9	200	376042	dairy
84	Chocolate Milk bar	1.2	100	654129	sweet
85	Gummy Bears	0.5	50	234712	sweet
86	Jelly Beans	1	100	418569	sweet
87	Lollipop	0.3	50	974813	sweet
88	Marshmallows	0.7	100	749484	sweet
89	Hard Candy	0.5	100	748987	sweet
90	Toffee	0.6	100	774623	sweet
91	Gum	0.4	40	215499	sweet
92	Chocolate Truffles	2.5	100	964513	sweet
108	Red wine	13.75	700	956615	alcohol
109	Vodka	23.99	1000	854132	alcohol
110	Beer	4.99	500	987451	alcohol
93	Frozen Vegetables (Mixed)	1.5	500	849623	frozen_food
94	Frozen Pizza Pepperoni	3	400	748914	frozen_food
95	Ice Cream	2.5	350	418566	frozen_food
96	Frozen Fish - filets	4	300	352179	frozen_food
97	Frozen berries (Mixed)	2.2	300	756777	frozen_food
111	Energy Drink 	3.5	500	422365	energy_drink
112	Vampire Energy Drink	4.5	500	987115	energy_drink
113	ProPower Energy Drink	8	1000	941023	energy_drink
\.


--
-- Data for Name: transaction_items; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.transaction_items (id, quantity, amount, product_fk, transaction_fk) FROM stdin;
1	3	55.08	4	1
2	1	90.85	9	1
3	2	18.68	15	1
\.


--
-- Data for Name: transactions; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.transactions (id, date, total_amount, employees_fk, customer_fk) FROM stdin;
1	2024-03-20 17:41:11	164.61	1	1
\.


--
-- Name: customers_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.customers_id_seq', 36, true);


--
-- Name: employees_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.employees_id_seq', 30, true);


--
-- Name: products_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.products_id_seq', 113, true);


--
-- Name: transaction_items_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.transaction_items_id_seq', 3, true);


--
-- Name: transactions_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.transactions_id_seq', 1, true);


--
-- Name: customers id_customers; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.customers
    ADD CONSTRAINT id_customers PRIMARY KEY (id);


--
-- Name: employees id_employees; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.employees
    ADD CONSTRAINT id_employees PRIMARY KEY (id);


--
-- Name: products id_products; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.products
    ADD CONSTRAINT id_products PRIMARY KEY (id);


--
-- Name: transaction_items id_transaction_items; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.transaction_items
    ADD CONSTRAINT id_transaction_items PRIMARY KEY (id);


--
-- Name: transactions id_transactions; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.transactions
    ADD CONSTRAINT id_transactions PRIMARY KEY (id);


--
-- Name: products prod_stamp; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER prod_stamp BEFORE INSERT OR UPDATE ON public.products FOR EACH ROW EXECUTE FUNCTION public.prod_stamp();


--
-- Name: transactions customer_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.transactions
    ADD CONSTRAINT customer_fk FOREIGN KEY (customer_fk) REFERENCES public.customers(id);


--
-- Name: transactions employee_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.transactions
    ADD CONSTRAINT employee_fk FOREIGN KEY (employees_fk) REFERENCES public.employees(id);


--
-- Name: transaction_items product_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.transaction_items
    ADD CONSTRAINT product_fk FOREIGN KEY (product_fk) REFERENCES public.products(id);


--
-- Name: transaction_items transaction_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.transaction_items
    ADD CONSTRAINT transaction_fk FOREIGN KEY (transaction_fk) REFERENCES public.transactions(id);


--
-- PostgreSQL database dump complete
--

