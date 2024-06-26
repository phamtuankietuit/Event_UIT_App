import React from "react";
import { Image, Text, TouchableOpacity, View } from "react-native";
import logo from "../../assets/images/Logo.png"
import { FontAwesomeIcon } from '@fortawesome/react-native-fontawesome';
import {
    faThumbsUp
} from '@fortawesome/free-solid-svg-icons';
const Page_Item = ({
    item,
    setLike
}) => {
    return (
        <TouchableOpacity className="h-[100px] bg-white flex items-center flex-row w-[98%] m-2 p-1 rounded-lg" style={{
            shadowColor: "#000",
            shadowOffset: {
                width: 0,
                height: 2,
            },
            shadowOpacity: 0.23,
            shadowRadius: 2.62,

            elevation: 4,
        }}>
            <View className="h-[100%] text-wrap w-[25%] flex items-center justify-center">
                <Image
                    source={logo}
                    className="bg-white rounded-full w-[75%] h-[90%] mr-4 "
                />
            </View>

            <View className="h-[100%] pt-2 w-[55%] flex justify-between">
                <View className="mt-2 mb-4 relative">
                    <Text className="text-[16px] font-semibold">
                        {item.namePage}
                    </Text>
                </View>
                <Text className="text-[13px] mb-7">
                    {item.star}
                    <Text> Lượt thích</Text>
                </Text>
            </View>
            <View className="h-[100%] w-[20%] flex justify-center items-center mr-2">
                {
                    item.like === true ? (
                        <TouchableOpacity className="flex flex-row bg-slate-200 p-2 rounded-lg" onPress={() => setLike(item.id, false)}>
                            <FontAwesomeIcon icon={faThumbsUp} color="#64748b" />
                            <Text className=" text-slate-500"> Đã thích</Text>
                        </TouchableOpacity>
                    ) : (
                        <TouchableOpacity className="flex flex-row bg-cyan-200 p-2 rounded-lg " onPress={() => setLike(item.id, true)}>
                            <FontAwesomeIcon icon={faThumbsUp} color="#06b6d4" />
                            <Text className=" text-cyan-500"> Thích</Text>
                        </TouchableOpacity>
                    )
                }

            </View>

        </TouchableOpacity>


    )
}

export default Page_Item