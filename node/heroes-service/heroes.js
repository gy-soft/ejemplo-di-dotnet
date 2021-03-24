function heroEntry(id, name, friends) {
    return [
        id,
        {
            id, name, friends
        }
    ]
}

const heroes = new Map();

heroes.set(...heroEntry('r2', 'R2D2', ['luke', 'kenobi']));
heroes.set(...heroEntry('solo', 'Han Solo', ['leia', 'luke']));
heroes.set(...heroEntry('luke', 'Luke Skywalker', ['r2', 'kenobi', 'solo']));
heroes.set(...heroEntry('kenobi', 'Obi Wan Kenobi', ['luke', 'r2', 'leia']));
heroes.set(...heroEntry('leia', 'Leia Amidala', ['luke', 'kenobi', 'solo']));

exports.heroes = heroes;