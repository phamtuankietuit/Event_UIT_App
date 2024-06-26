import { Text, TextInput, TouchableOpacity, View } from "react-native"
import { FontAwesomeIcon } from '@fortawesome/react-native-fontawesome';
import {
    faSearch
} from '@fortawesome/free-solid-svg-icons';
const SearchBar = ({
    value,
    placeholder,
    handleChange,
    search
}) => {
    return (
        <View className="flex border bg-white border-slate-300 flex-row items-center py-2 px-4 rounded-lg" >
            <TextInput
                className="flex-1  text-sm"
                value={value}
                placeholder={placeholder}
                onChangeText={handleChange}
            />
            <TouchableOpacity onPress={search}>
                <FontAwesomeIcon icon={faSearch} />
            </TouchableOpacity>
        </View>

    )
}

export default SearchBar