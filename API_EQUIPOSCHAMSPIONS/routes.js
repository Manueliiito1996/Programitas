// Rutas //
const express = require("express")
const app = express();
const router = express.Router();

// LEAGUES //

const { leagues } = require('./leagues');

router.get('/api/leagues', (req, res) => {
    res.send(leagues);
});

router.get('/api/leagues/:lid', (req, res) => {
    const league = leagues.find(c => c.lid === parseInt(req.params.lid));
    if(!league) return res.status(404).send('League Not Found');
    else res.send(league);
});

router.post('/api/leagues', (req, res) => {
    const league = {
        lid: leagues.length + 1,
        country: req.body.country,
        league: req.body.league,
    };

    leagues.push(league); 
    res.send(league);
});


router.delete('/api/leagues/:lid', (req, res) => {
    const league = leagues.find(c => c.lid === parseInt(req.params.lid));
    if(!leagues) return res.status(404).send('League Not Found');

    const index = leagues.indexOf(league);
    leagues.splice(index, 1);
    res.send(league);
});

// Inicio //

router.get('/', (req, res) => {
    res.send('Welcome to Oficial Website from Champions League');
});

// TEAMS //

const { teams } = require('./teams');


router.get('/api/teams', (req, res) => {
    res.send(teams);
});

router.get('/api/teams/:id', (req, res) => {
    const team = teams.find(c => c.id === parseInt(req.params.id));
    if(!team) return res.status(404).send('Team Not Found');
    else res.send(team);
});

router.post('/api/teams', (req, res) => {
    const team = {
        id: teams.length + 1,
        name: req.body.name,
        league: req.body.league,
        leader: (req.body.leader === 'true')
    }; 

    teams.push(team); 
    res.send(team);
});


router.delete('/api/teams/:id', (req, res) => {
    const team = teams.find(c => c.id === parseInt(req.params.id));
    if(!teams) return res.status(404).send('Team Not Found');

    const index = teams.indexOf(team);
    teams.splice(index, 1);
    res.send(team);
});

app.use('/', router);

module.exports = { router };